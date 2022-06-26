using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// SOLID (I- Interface segregation principle)
// The principle of distribution of the interface is as follows:
// customers should not depend on methods that they do not use.
// An example of how not to do:
namespace Interface_4
{
    // Basic interface for a device. It allows us to make calls, use the phone book,
    // play games, use the Internet, read books and set the alarm.
    interface IDevice
    {
        void MakeACall(string number);
        string FindContact(string name);
        void CreateNewContact(string number, string name);
        void CreateNewMessage(string text);
        void SendMessage(string to, string text);
        DateTime GetCurrentTime();
        void SetTime(DateTime time);
        void SetAlarmTime(DateTime time);
        void ChooseMelody(string name);
        void ConnectToInternet(string password);
        void UseBrowser(string name);
        void DownloadProgram(string name);
        void UseOnlineService(string name);
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