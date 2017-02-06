using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace allocationsystem
{
    public partial class Form5 : Form
    {
        DataTable dataTable;
        public Form5()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataTable.Columns.Add("Date", typeof(String));
            dataTable.Columns.Add("Slot", typeof(String));
            dataTable.Columns.Add("No. Rooms", typeof(int));
            //dataTable.Columns.Add("1", typeof(String));
            //dataTable.Columns.Add("2", typeof(String));
            //dataTable.Columns.Add("3", typeof(String));
            //dataTable.Columns.Add("4", typeof(String));
            //dataTable.Columns.Add("5", typeof(String));
            //dataTable.Columns.Add("6", typeof(String)); 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Object[,] listOfFaculty = new Object[,] { { "Umadevi V", 4 }, 
                                                        {"Selva Kumar",3},
                                                        {"Sayed Akram",5},
                                                        {"Panimozhi",2},
                                                        {"Nandini Vineeth",4},
                                                        {"Namratha",5},
                                                        {"Saritha AN",5},
                                                        {"Asha",4},
                                                        {"Madhvi",4}};
            Object[][] faculty = new Object[listOfFaculty.Length/2][];// n faculty members are being considered
            for (int i=0;i<faculty.Length;i++)
            {
                faculty[i] = new Object[2];
                faculty[i][0] = listOfFaculty[i,0];
                faculty[i][1] = listOfFaculty[i,1];
            }
            foreach (Object[] x in faculty)
            {
                Console.Write("\n" + x[0]+"\t"+x[1]);
            }
            Object[,] listOfDates = new Object[,] { { "12-02-17", "9:30 to 12:30", 6 }, 
                                                    {"13-02-17","9:30 to 12:30",6},
                                                    {"14-02-17","9:30 to 12:30",5},
                                                    {"15-02-17","9:30 to 12:30",3},
                                                    {"16-02-17","9:30 to 12:30",7},
                                                    {"17-02-17","9:30 to 12:30",6}};
            int numberOfExamDays = 6;
            ExamDay[] dates;
            dates = new ExamDay[numberOfExamDays];
            for (int i = 0; i < numberOfExamDays; i++)
            {
                dates[i] = new ExamDay((String)listOfDates[i,0],(String)listOfDates[i,1],(int)listOfDates[i,2]);
            }

            int[][] AllotmentTable;
            AllotmentTable= new int[numberOfExamDays][];// this means 6 days
            //Console.Write(AllotmentTable.Length);
            for (int i = 0; i < AllotmentTable.Length; i++)
            {
                AllotmentTable[i] = new int[dates[i].numberOfRooms];
            }
            FillAllotmentTable(faculty , dates, AllotmentTable);
            int roomIndex = 1;
            for (int i = 0; i < numberOfExamDays; i++)
            {
                ArrayList list = new ArrayList(); 
                //Console.Write("\n"+dates[i].date + "" + dates[i].slot + "\t" + dates[i].numberOfRooms + "\t");
                list.Add(dates[i].date);
                list.Add(dates[i].slot);
                list.Add(dates[i].numberOfRooms);
                foreach (int x in AllotmentTable[i])
                {
                    list.Add(faculty[x][0]);
                    //Console.Write(faculty[x][0]+"\t");
                }
                Object [] rowParams = list.ToArray();
                while (dataTable.Columns.Count < rowParams.Length)
                {
                    dataTable.Columns.Add("Room"+roomIndex++, typeof(String));
                }
                dataTable.Rows.Add(rowParams);
                //Console.Write("");
            }
            //Console.Read();
            dataGridView1.DataSource = dataTable;
        }

        public static void FillAllotmentTable(Object[][]faculty , ExamDay[] dates, int[][]AllotmentTable)
        {
            int noFac = faculty.Length;
            int currFacIndex = 0;
            foreach (int[] day in AllotmentTable)
            {
                for (int i = 0; i < day.Length; i++)
                {
                    while ((int)faculty[currFacIndex][1] < 1)
                    {
                        currFacIndex++;
                        currFacIndex %= noFac;
                    }
                    day[i] = currFacIndex;
                    faculty[currFacIndex][1] = (int)faculty[currFacIndex][1]-1;
                    currFacIndex++;
                    currFacIndex %= noFac;
                }
            }
        }

    }
    public class ExamDay
    {
        public String date;
        public String slot;
        public int numberOfRooms;
        public ExamDay(String d,String s,int nor)
        {
            date = d;
            slot = s;
            numberOfRooms = nor;
        }
    }
}
