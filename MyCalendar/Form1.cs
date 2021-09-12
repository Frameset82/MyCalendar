﻿using System;
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

        // 지정된 달의 날짜 데이터 가져오기
        private void setDate(DateTime selectedDate)
        {
            clearDayLabels();
            setCurrentDate(selectedDate);
            Dictionary<int, string> holidayDate = getHoliday(selectedDate);
            DateTime startDay = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            int endDay = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            int startDayWeek = (int)startDay.DayOfWeek;

            for (int i = 1; i <= endDay; i++)
            {
                int index = i + startDayWeek - 1;

                dayLabels[index].Text = string.Format("{0:0}", i);

                // 공휴일 체크
                if (holidayDate != null && holidayDate.ContainsKey(i))
                {
                    dayLabels[index].ForeColor = System.Drawing.Color.Red;
                    dayLabels[index].Text += "\n" + holidayDate[i];
                }
                else
                {   // 일요일 체크
                    if (index % 7 == 0)
                    {
                        dayLabels[index].ForeColor = System.Drawing.Color.Red;
                    }
                    else dayLabels[index].ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        // 지정된 날짜를 입력받아 해당 월의 공휴일 정보(Dictionary<int, string>)를 반환
        private Dictionary<int, string> getHoliday(DateTime selectedDate)
        {
            Dictionary<int, string> holidayDate = new Dictionary<int, string>();
            switch (selectedDate.Month)
            {
                case 1:
                    holidayDate.Add(1, "신정");
                    break;
                case 3:
                    holidayDate.Add(1, "삼일절");
                    break;
                case 5:
                    holidayDate.Add(5, "어린이날");
                    break;
                case 6:
                    holidayDate.Add(6, "현충일");
                    break;
                case 8:
                    holidayDate.Add(15, "광복절");
                    break;
                case 10:
                    holidayDate.Add(3, "개천절");
                    holidayDate.Add(9, "한글날");
                    break;
                case 12:
                    holidayDate.Add(25, "크리스마스");
                    break;
                default:
                    break;
            }
            // 설 연휴 음력 계산
            DateTime dateTime = new DateTime(selectedDate.Year, 1, 1);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            if (dateTime.Month == selectedDate.Month)
            {
                holidayDate.Add(dateTime.Day - 1, "설 연휴");
                holidayDate.Add(dateTime.Day, "설날");
                holidayDate.Add(dateTime.Day + 1, "설 연휴");
            }
            // 추석 연휴 음력 계산
            dateTime = new DateTime(selectedDate.Year, 8, 15);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            if (dateTime.Month == selectedDate.Month)
            {
                holidayDate.Add(dateTime.Day - 1, "추석 연휴");
                holidayDate.Add(dateTime.Day, "추석");
                holidayDate.Add(dateTime.Day + 1, "추석 연휴");
            }
            // 석가탄신일 음력 계산
            dateTime = new DateTime(selectedDate.Year, 4, 8);
            dateTime = convertLunarToSolar(dateTime.Year, dateTime.Month, dateTime.Day);
            if (dateTime.Month == selectedDate.Month)
            {
                holidayDate.Add(dateTime.Day, "석가탄신일");
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
            {   //음력은 마지막 날짜가 매달 다르기 때문에 예외 뜨면 그날 맨 마지막 날로 지정
                return lunarCalenar.ToDateTime(lunarYear, lunarMonth, lunarCalenar.GetDaysInMonth(lunarYear, lunarDay), 0, 0, 0, 0);
            }
            return lunarCalenar.ToDateTime(lunarYear, lunarMonth, lunarDay, 0, 0, 0, 0);
        }

        // 일자 데이터 라벨 행렬 생성
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
                    dayLabel.AutoSize = false;
                    dayLabel.ForeColor = Color.Black;
                    dayLabel.BackColor = Color.White;
                    dayLabel.TextAlign = ContentAlignment.TopLeft;
                    dayLabel.Font = new Font("맑은 고딕", 11, FontStyle.Bold);
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
            for (int i = 0; i < 42; i++)
            {
                dayLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                dayLabels[i].BackColor = Color.White;
                dayLabels[i].Cursor = Cursors.Default;
                dayLabels[i].Text = string.Empty;
            }
        }
    }
}
