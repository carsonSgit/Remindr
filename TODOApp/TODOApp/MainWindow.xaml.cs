using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Reflection;

namespace TODOApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int liState = 0;
        private List<Task> sampleTasks = new List<Task>();
        private string filePath = "./Data.csv";
        private string saveLocation;

        public MainWindow()
        {
            InitializeComponent();
            if (sampleTasks.Count == 0 )
                PopulateSampleData();

            liv_tasks.ItemsSource = sampleTasks.ToList();
        }

        private void btn_sort_Click(object sender, RoutedEventArgs e)
        {
            // Orders the task list by DateTime value (this way is less efficient)
            /*sampleTasks = sampleTasks.OrderBy(task => task.Date).ToList();
            liv_tasks.ItemsSource = sampleTasks;*/

            // More "efficient" way of going about things
            liv_tasks.ItemsSource = sampleTasks.OrderBy(task => task.Date).ToList();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(saveLocation)) 
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV File | *.csv | All Files | *.*";

                if ((bool)sfd.ShowDialog())
                {
                    saveLocation= sfd.FileName;
                }
            }
            
            ConvertToCSV(sampleTasks, filePath);
        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {
            // check if file exists
            if (File.Exists(filePath))
            {
                PopulateSampleData(filePath);
            }
            else
            {
                // Show message to user if file does not exist
                MessageBox.Show($"Error: file \"{filePath}\" does not exist");
            }

            liv_tasks.ItemsSource = sampleTasks.ToList();
        }

        private void btn_dueToday_Click(object sender, RoutedEventArgs e)
        {   
            // Will definitely be changing property name of Task.Date / maybe change the implementation as well
            List<Task> dueToday = sampleTasks.Where(task => task.Date.Date == DateTime.Today.Date).ToList();
            string message = null;

            if(dueToday.Count > 0)
            {
                foreach (Task t in dueToday)
                {
                    // no need for printing task date as it's known it's today
                    message += t.Name + " | " + t.Notes + Environment.NewLine;
                }
                message += $"\nYou have {dueToday.Count} thing(s) left to do!";
                MessageBox.Show(message, "Due Today");
            }
            else
            {
                MessageBox.Show("You have nothing due today!", "Due Today");
            }
        }

        private void btn_overdue_Click(object sender, RoutedEventArgs e)
        {
            // Very slight difference between this and dueToday
            // Will definitely be changing property name of Task.Date / maybe change the implementation as well
            List<Task> overdue = sampleTasks.Where(task => task.Date.Date < DateTime.Today.Date).ToList();
            string message = null;
            if(overdue.Count > 0)
            {
                foreach (Task t in overdue)
                {
                    message += t.Name + " | " + t.Date + " | " + t.Notes + Environment.NewLine;
                }
                message += $"\nYou have {overdue.Count} thing(s) overdue!";
                MessageBox.Show(message, "Overdue");
            }
            else
            {
                MessageBox.Show("You're all caught up!", "Overdue");
            }
        }

        private void btn_addTask_Click(object sender, RoutedEventArgs e)
        {
            // if displaying sample data 
            if (liState == 0)
            {
                // clear all sample data
                sampleTasks.Clear();
            }

            // change list state to 1
            liState = 1;

            // add new task
            sampleTasks.Add(new Task() { Name = txb_taskName.Text, Date = (DateTime)dtp_dueDate.SelectedDate, Notes = txb_notes.Text });

            liv_tasks.ItemsSource = sampleTasks.ToList();
        }

        private void btn_eraseContent_Click(object sender, RoutedEventArgs e)
        {
            // Sets values to default
            txb_notes.Text = txb_taskName.Text = string.Empty;
            dtp_dueDate.SelectedDate= DateTime.Now;
        }

        private void PopulateSampleData()
        {
            // Sample data
            sampleTasks.Clear();
            sampleTasks.Add(new Task() { Name = "Water Plants", Date = DateTime.Now, Notes="Check the soil as well" });
            sampleTasks.Add(new Task() { Name = "Go to gym", Date = (DateTime.Now).AddDays(1), Notes = "Get fit" });
            sampleTasks.Add(new Task() { Name = "Sample overdue task", Date = (DateTime.Now).AddDays(-1), Notes = "it is overdue" });

        }

        private void PopulateSampleData(string filePath)
        {
            // read the file using stream reader if it exists
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                // read till EOF
                while ((line = sr.ReadLine()) != null)
                {
                    // split each line into an array of data for object creation
                    string[] data = (line.Trim()).Split(",");

                    // if name and due date (required fields) are specified
                    if (data.Length > 1)
                    {
                        // clear the tasks lists first if it is displaying sample tasks
                        if (liState == 0)
                            sampleTasks.Clear();

                        // change list state since it is populated with meaningful data
                        liState = 1;

                        // populate data accordingly
                        if (data.Length == 2)
                        {
                            sampleTasks.Add(new Task(data[0], DateTime.Parse(data[1])));
                        }
                        else if (data.Length == 3)
                        {   
                            // #*@)!(#*@!)(#*!@)(#*@!(#(!@*#!@*#!@)(#*!@)(#*(!@)#*!@)($&@)!(*^%!&*@)^*&#($^!#*&(!@%^ data[3] NO! data[2] :)
                            sampleTasks.Add(new Task(data[0], DateTime.Parse(data[1]), data[3]));
                        }
                    }
                }
            }
        }

        private void ConvertToCSV(List<Task> tasks, string filePath)
        {
            List<string> strings= new List<string>();

            // hard code value, PropertyInfo[] can also be used
            string header = "Name, Due Date, Notes";

            // append header
            strings.Append(header);

            // append each object
            foreach (Task task in tasks)
            {
                strings.Append($"{task.Name}, {task.Date}, {task.Notes}");
            }

            // write to file
            File.WriteAllLines(filePath, strings.ToArray());
        }
    }
}
