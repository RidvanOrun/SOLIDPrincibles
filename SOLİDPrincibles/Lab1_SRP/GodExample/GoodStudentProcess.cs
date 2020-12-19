using SOLİDPrincibles.Lab1_SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab1_SRP.GodExample
{
    public class GoodStudentProcess
    {
        //Insert işlemi ve loglama işlemi ayrı classlarda icra edildi.

        GoodLogerProcess logger;

        public GoodStudentProcess() => logger = new GoodLogerProcess();

        string log;

        public bool InsertEmployee(Student student)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(student.Id);               
                sb.Append(student.FullName);               
                sb.Append(student.University);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\StudentLog.txt", log);

                log = logger.BuildLog($"Student insert successfull -- {student.Id}");
                logger.LogFile(@"C:\StudentLog.txt", log);

                return true;

            }
            catch (Exception ex)
            {
                log = logger.BuildLog("Hata Mesajı: " + ex.Message);
                logger.LogFile(@"C:\StudentLog.txt", log);

                return false;
            }
        }


    }
}
