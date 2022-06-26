using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Interface_5
{
    //ICallingDevice is responsible for the logic for making calls
    interface ICallingDevice
    {
        void MakeACall(string number);
        string FindContact(string name);
        void CreateNewContact(string number, string name);
        void CreateNewMessage(string text);
        void SendMessage(string to, string text);
    }
    // IAlarmClock is responsible for the logic of the device,
    // which relates to the use of the clock and alarm clock
    interface IAlarmClock
    {
        DateTime GetCurrentTime();
        void SetTime(DateTime time);
        void SetAlarmTime(DateTime time);
        void ChooseMelody(string name);
    }
    // INetworkDevice is responsible for the behavior of the network device
    interface INetworkDevice
    {
        void ConnectToInternet(string password);
        void UseBrowser(string name);
        void DownloadProgram(string name);
        void UseOnlineService(string name);
    }
    // IReaderDevice - allows you to define the functionality for reading devices (e-book).
    interface IReaderDevice
    {
        void FindBook(string name);
        void OpenBook(string name, int page);
        void NextPage(string book, int currentPage);
        void PreviousPage(string book, int currentPage);
        void CreateBookmark(string book, int page);
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}