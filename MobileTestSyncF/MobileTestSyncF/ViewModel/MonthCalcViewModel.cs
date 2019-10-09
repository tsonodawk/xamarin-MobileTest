using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MobileTestSyncF.Models;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace MobileTestSyncF.ViewModel
{
    public class MonthCalcViewModel
    {

        public ObservableCollection<MonthCalc> MonthCalcs { get; set; }
        List<string> eventNameCollection;
        List<Color> colorCollection;
        public MonthCalcViewModel()
        {
            MonthCalcs = new ObservableCollection<MonthCalc>();
            CreateEventNameCollection();
            CreateColorCollection();
            CreateAppointments();
        }

        /// <summary>
        /// Creates MonthCalcs and stores in a collection.  
        /// </summary>
        private void CreateAppointments()
        {
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GettingTimeRanges();
            DateTime date;
            DateTime DateFrom = DateTime.Now.AddDays(-10);
            DateTime DateTo = DateTime.Now.AddDays(10);
            DateTime dataRangeStart = DateTime.Now.AddDays(-3);
            DateTime dataRangeEnd = DateTime.Now.AddDays(3);

            for (date = DateFrom; date < DateTo; date = date.AddDays(1))
            {
                if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
                {
                    for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
                    {
                        MonthCalc MonthCalc = new MonthCalc();
                        int hour = (randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y));
                        MonthCalc.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                        MonthCalc.To = (MonthCalc.From.AddHours(1));
                        MonthCalc.EventName = eventNameCollection[randomTime.Next(9)];
                        MonthCalc.color = colorCollection[randomTime.Next(9)];
                        if (AdditionalAppointmentIndex % 3 == 0)
                            MonthCalc.AllDay = true;
                        MonthCalcs.Add(MonthCalc);
                    }
                }
                else
                {
                    MonthCalc MonthCalc = new MonthCalc();
                    MonthCalc.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(9, 11), 0, 0);
                    MonthCalc.To = (MonthCalc.From.AddHours(1));
                    MonthCalc.EventName = eventNameCollection[randomTime.Next(9)];
                    MonthCalc.color = colorCollection[randomTime.Next(9)];
                    MonthCalcs.Add(MonthCalc);
                }
            }
        }

        /// <summary>  
        /// Creates event names collection.  
        /// </summary>  
        private void CreateEventNameCollection()
        {
            eventNameCollection = new List<string>();
            eventNameCollection.Add("General MonthCalc");
            eventNameCollection.Add("Plan Execution");
            eventNameCollection.Add("Project Plan");
            eventNameCollection.Add("Consulting");
            eventNameCollection.Add("Performance Check");
            eventNameCollection.Add("Yoga Therapy");
            eventNameCollection.Add("Plan Execution");
            eventNameCollection.Add("Project Plan");
            eventNameCollection.Add("Consulting");
            eventNameCollection.Add("Performance Check");
        }

        /// <summary>  
        /// Creates color collection.  
        /// </summary>  
        private void CreateColorCollection()
        {
            colorCollection = new List<Color>();
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF1BA1E2"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
        }

        /// <summary>
        /// Gets the time ranges.
        /// </summary>
        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }


        //public ScheduleAppointmentCollection AppointmentCollection { get; set; }
        //public MonthCalcViewModel()
        //{
        //    AppointmentCollection = new ScheduleAppointmentCollection();
        //    //Creating new event   
        //    var clientMonthCalc = new Syncfusion.SfSchedule.XForms.ScheduleAppointment();
        //    DateTime currentDate = DateTime.Now;
        //    DateTime startTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 10, 0, 0);
        //    DateTime endTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 12, 0, 0);
        //    clientMonthCalc.StartTime = startTime;
        //    clientMonthCalc.EndTime = endTime;
        //    clientMonthCalc.Color = Color.Green;
        //    clientMonthCalc.Subject = "ClientMonthCalc";
        //    AppointmentCollection.Add(clientMonthCalc);

        //}
    }
}
