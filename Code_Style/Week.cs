/********************** Module Header ***********************\
  Module Name: Week.cs
  Project:  Code_Style
  Juan Jesús Ojeda Castelo 
  Creates an enum with the week days.
  License 
/******************************************************************/


using System;

namespace Code_Style
{
    public enum Days 
    { 
        None = 0b_0000_0000, //0
        Monday = 0b_0000_0001, // 1
        Tuesday = 0b_0000_0010, //2
        Wednesday = 0b_0000_0100, //4
        Thursday = 0b_0000_1000, //8
        Friday = 0b_0001_0000,  //16
        Saturday = 0b_0010_0000, //32
        Sunday = 0b_0100_000 //64
    }

    class Week
    {

        public void showWorkDays()
        {
            Days work_days = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine("The working days are: " + work_days);
        }
    }
}
