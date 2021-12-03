using System;
using System.Windows.Forms;

namespace TrainBrainScoreBoard
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    /**
     * ��������� ������ ����������
     * 
     * ��������! �� ��������� ������ ������ ����� �����, 
     * ��� ��������� ������ ���������� ����������
     */
    public static class Storage
    {
        #pragma warning disable CA2211

        // ��������� ����������� ���������
        public static bool controlsActiveState = false;

        // ����� ��������� ����� �������
        public static System.IO.Stream tablesFile = null;

        // ������� ������� ���� ���������
        public static System.Data.DataTable workTable = null;

        /* 
         * ���������� ��������� ����������
         */

        // ����������� ������ � ��������� �������
        public static bool teamsShowInRandomOreder = false;

        // �������� ��������� ����� �� ����� ������
        public static bool replaceRandomNumbersWithTeamNames = false;

        // ���������� ������������� ����� ���������� � ������� ������
        public static bool fullscrennFormsWindowedDisplay = false;

        // ��������� ������������� ����� � �������� ������� (�������� �� CPU)
        public static bool fullscreenFormsRealtimeUpdate = false;

        /*
         * ����� ����������
         */

        // ����� ����������� ������
        public static Form TableDisplay = new TableDisplay();

        // ����� ������ ���������� (���������) ����������
        public static Form WinnerSelect = new WinnerSelect();

        /*
         * �������� ����������
         */

        // ������� ������� ��� ����������� ������������� ����
        public static int currentSelectedDisplay = 0;

        // ������������ ���������� ����������� � ������ ���������� ����������
        public static int maxWinnersCount = 1;

        // ���-�� ������ � ������ ���������� ����������
        public static int teamsCount = 0;

        public static float fontSize = 14.0f;

        /*
         * ��������� ���������� (���������, �������� ������/����� � �.�.)
         */

        public static readonly string openFileButton_openMode = "������� �������";
        public static readonly string openFileButton_closeMode = "������� �������";
        public static readonly string label_currentTableGameName_empty = "�������� ����, ����� ����������";
        public static readonly string textBox_fileName_empty = "�������� ����, ����� ����������";

        #pragma warning restore CA2211
    }
}
