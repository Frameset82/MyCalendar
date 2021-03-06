using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class Form1 : Form
    {
        private DateTime currentDate = DateTime.Now; // 현재 날짜 초기화
        Label[] dayLabels = new Label[42];           // 일자 라벨 배열 변수

        public Form1()
        {
            InitializeComponent();
            setRowColumns();
            setDate(currentDate);
        }

        // 현재 달 라벨 마우스호버 이벤트 메서드
        private void currentMonthLabel_MouseHover(object sender, EventArgs e)
        {
            monthLabel.ForeColor = Color.Blue;
        }
        private void currentMonthLabel_MouseLeave(object sender, EventArgs e)
        {
            monthLabel.ForeColor = Color.Black;
        }

        // 현재 달 라벨 클릭 메서드(오늘 날짜로 달력 이동)
        private void currentMonthLabel_Clicked(object sender, EventArgs e)
        {
            DateTime currentMonthDate = DateTime.Now;
            setDate(currentMonthDate);
        }

        // 다음 달 버튼 클릭 메서드
        private void nextMonthBtn_Clicked(object sender, EventArgs e)
        {
            DateTime nextMonthDate = currentDate.AddMonths(1);
            setDate(nextMonthDate);
        }

        // 이전 달 버튼 클릭 메서드
        private void previousMonthBtn_Clicked(object sender, EventArgs e)
        {
            DateTime previousMonthDate = currentDate.AddMonths(-1);
            setDate(previousMonthDate);
        }

        // 달력 현재 날짜 지정
        private void setCurrentDate(DateTime selectedDate)
        {
            string currentMonth = selectedDate.Month.ToString();
            string currentYear = selectedDate.Year.ToString();
            monthLabel.Text = currentMonth + "월";
            yearLabel.Text = currentYear + "년";
            currentDate = selectedDate;
        }

        // 지정된 달의 날짜 데이터 지정
        private void setDate(DateTime selectedDate)
        {
            clearDayLabels();
            setCurrentDate(selectedDate);

            Dictionary<int, List<string>> holidayDate = getHoliday(selectedDate);
            DateTime startDay = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            int endDay = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            int startDayWeek = (int)startDay.DayOfWeek;

            for (int i = 1; i <= endDay; i++)
            {
                int index = i + startDayWeek - 1;
                dayLabels[index].Text = string.Format("{0:0}", i);
                //dayLabels[index].Text = i.ToString();

                // 공휴일 체크
                if (holidayDate != null && holidayDate.ContainsKey(i))
                {
                    dayLabels[index].ForeColor = Color.Red;
                    dayLabels[index].BackColor = Color.FromArgb(255, 220, 220);
                    for (int j = 0; j < holidayDate[i].Count; j++)
                    {
                        dayLabels[index].Text += "\n" + holidayDate[i][j];
                    }
                }
                else
                {   // 일요일 체크
                    if (index % 7 == 0)
                    {
                        dayLabels[index].ForeColor = Color.Red;
                    }
                    else dayLabels[index].ForeColor = Color.Black;
                }
                // 오늘 일자 체크(라벨 테두리 on, 배경색 녹색(180, 255, 180))
                // 테두리 생성은 깜빡이는 현상 발생시킴 -> 보류
                if (selectedDate.Year == DateTime.Now.Year && selectedDate.Month == DateTime.Now.Month && selectedDate.Day == i)
                {
                    //dayLabels[index].BorderStyle = BorderStyle.FixedSingle;
                    dayLabels[index].BackColor = Color.FromArgb(180, 255, 180);
                }
            }
        }

        // 지정된 날짜를 입력받아 해당 월의 공휴일 정보(Dictionary<int, List<string>)를 반환
        // 같은날 일반 공휴일과 음양력 변환이 필요한 공휴일이 겹칠경우를 위해 딕셔너리 value값을 리스트로 사용
        private Dictionary<int, List<string>> getHoliday(DateTime selectedDate)
        {
            Dictionary<int, List<string>> holidayDate = new Dictionary<int, List<string>>();
            // 일반 공휴일 추가 작업
            switch (selectedDate.Month)
            {
                case 1:
                    holidayDate.Add(1, new List<string> { "신정" });
                    break;
                case 3:
                    holidayDate.Add(1, new List<string> { "삼일절" });
                    break;
                case 5:
                    holidayDate.Add(5, new List<string> { "어린이날" });
                    break;
                case 6:
                    holidayDate.Add(6, new List<string> { "현충일" });
                    break;
                case 8:
                    holidayDate.Add(15, new List<string> { "광복절" });
                    break;
                case 10:
                    holidayDate.Add(3, new List<string> { "개천절" });
                    holidayDate.Add(9, new List<string> { "한글날" });
                    break;
                case 12:
                    holidayDate.Add(25, new List<string> { "크리스마스" });
                    break;
                default:
                    break;
            }

            // 음력 -> 양력 데이터 변환이 필요한 공휴일 체크
            // 휴일 하나씩 모두 검사해야 연휴가 있음에도 표시되지 않는 결함을 해결할 수 있음
            // 일반 공휴일과 겹칠시 일반 공휴일을 우선 표시 ex(어린이날과 석가탄신일이 겹칠경우 어린이날이 위에 표시)

            // 설 연휴 음력 계산
            DateTime dateTime = new DateTime(selectedDate.Year -1, 12, 30);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "설 연휴");

            dateTime = new DateTime(selectedDate.Year, 1, 1);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "설날");

            dateTime = new DateTime(selectedDate.Year, 1, 2);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "설 연휴");

            // 추석 연휴 음력 계산
            dateTime = new DateTime(selectedDate.Year, 8, 14);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "추석 연휴");

            dateTime = new DateTime(selectedDate.Year, 8, 15);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "추석");
   
            dateTime = new DateTime(selectedDate.Year, 8, 16);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "추석 연휴");

            // 석가탄신일 음력 계산
            dateTime = new DateTime(selectedDate.Year, 4, 8);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            holidayDate = setLunarHoliday(dateTime, selectedDate, holidayDate, "석가탄신일");
            
            return holidayDate;
        }

        // 음력 공휴일을 휴일 데이터(Dictionary)에 추가 하는 메서드(Dictionary<int, List<string>> 반환)
        // 인자 목록
        // 양력으로 변환된 공휴일 DateTime dateTime
        // 현재 지정된 날짜 DateTime selectedDate
        // 휴일 데이터를 추가할 곳 Dictionary<int, List<string>> holidayDate
        // 추가할 휴일 이름 string holiday
        private Dictionary<int, List<string>> setLunarHoliday(
            DateTime dateTime, DateTime selectedDate, Dictionary<int, List<string>> holidayDate, string holiday)
        {
            if (dateTime.Month == selectedDate.Month)
            {
                if (holidayDate.ContainsKey(dateTime.Day))
                {
                    holidayDate[dateTime.Day].Add(holiday);
                }
                else
                {
                    holidayDate.Add(dateTime.Day, new List<string> { holiday });
                }
            }
            return holidayDate;
        }

        // 음력데이터를 양력으로 변환하여(DateTime) 반환
        // lunarCalenar = 음력
        // leapMonth = 윤달
        private DateTime convertLunarToSolar(int lunarYear, int lunarMonth, int lunarDay)
        {
            // 음양력 날짜 데이터 클래스
            System.Globalization.KoreanLunisolarCalendar lunarCalenar = new System.Globalization.KoreanLunisolarCalendar();
            // 해당 연도,달이 윤달인지 판단
            bool isLeapMonth = lunarCalenar.IsLeapMonth(lunarYear, lunarMonth);
            // 윤달 카운드 변수
            int leapMonthCount;
            // 입력받은 연도의 개월수 만큼
            if (lunarCalenar.GetMonthsInYear(lunarYear) > 12)
            {
                leapMonthCount = lunarCalenar.GetLeapMonth(lunarYear);
                if (isLeapMonth)
                    lunarMonth++;
                if (lunarMonth > leapMonthCount)
                    lunarMonth++;
            }
            try
            {
                lunarCalenar.ToDateTime(lunarYear, lunarMonth, lunarDay, 0, 0, 0, 0);
            }
            catch
            {   // 음력은 마지막 날짜가 매달 다르기 때문에 예외 발생시 마지막 일로 지정
                return lunarCalenar.ToDateTime(lunarYear, lunarMonth, lunarCalenar.GetDaysInMonth(lunarYear, lunarMonth), 0, 0, 0, 0);
            }
            return lunarCalenar.ToDateTime(lunarYear, lunarMonth, lunarDay, 0, 0, 0, 0);
        }

        // 일자 라벨 행렬 생성
        private void setRowColumns()
        {
            for (int i = 0; i < 7; i++)
            {
                dayLayoutTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            for (int i = 0; i < 6; i++)
            {
                dayLayoutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Label dayLabel = new Label();
                    dayLabel.AutoSize = true;
                    dayLabel.BackColor = Color.White;
                    dayLabel.TextAlign = ContentAlignment.TopLeft;
                    dayLabel.Font = new Font("맑은 고딕", 9, FontStyle.Regular);
                    dayLabel.BorderStyle = BorderStyle.None;
                    dayLabel.Margin = new Padding(1);
                    dayLabel.Padding = new Padding(0);
                    dayLabel.Dock = DockStyle.Fill;
                    dayLabels[(j * 7) + i] = dayLabel;
                    dayLayoutTable.Controls.Add(dayLabel, i, j);
                }
            }
        }

        // 일자 라벨 데이터 초기화
        public void clearDayLabels()
        {
            for (int i = 0; i < dayLabels.Length; i++)
            {
                dayLabels[i].BorderStyle = BorderStyle.None;
                dayLabels[i].BackColor = Color.White;
                dayLabels[i].Text = string.Empty;
            }
        }
    }
}
