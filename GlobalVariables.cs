using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker
{
    class GlobalVariables
    {
        private static string v_Budget = "", v_updated = "", v_setBudget = "";
        private static double v_dbudget = 0, v_budNum = 0, v_percentage = 0, v_spent = 0, v_addBack = 0, v_numOnly = 0;
        private static bool v_update = false, v_isempty = false, v_isNum = false;
        private static int v_iPercent = 0, v_DashCounter = 0, v_MonthCounter = 0;

        public static string Budget
        {
            get { return v_Budget; }
            set { v_Budget = value; }
        }
        public static string Updated
        {
            get { return v_updated; }
            set { v_updated = value; }
        }
        public static string SetBudget
        {
            get { return v_setBudget; }
            set { v_setBudget = value; }
        }
        public static double Dbudget
        {
            get { return v_dbudget; }
            set { v_dbudget = value; }
        }
        public static double BudNum
        {
            get { return v_budNum; }
            set { v_budNum = value; }
        }
        public static double Percentage
        {
            get { return v_percentage; }
            set { v_percentage = value; }
        }
        public static double Spent
        {
            get { return v_spent; }
            set { v_spent = value; }
        }
        public static double AddBack
        {
            get { return v_addBack; }
            set { v_addBack = value; }
        }
        public static double NumOnly
        {
            get { return v_numOnly; }
            set { v_numOnly = value; }
        }
        public static int In_Percent
        {
            get { return v_iPercent; }
            set { v_iPercent = value; }
        }
        public static bool Update
        {
            get { return v_update; }
            set { v_update = value; }
        }
        public static bool Isempty
        {
            get { return v_isempty; }
            set { v_isempty = value; }
        }
        public static bool IsNum
        {
            get { return v_isNum; }
            set { v_isNum = value; }
        }
        public static int DashCounter
        {
            get { return v_DashCounter; }
            set { v_DashCounter = value; }
        }
        public static int MonthCounter
        {
            get { return v_MonthCounter; }
            set { v_MonthCounter = value; }
        }

    }
}