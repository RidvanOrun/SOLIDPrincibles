using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLİDPrincibles.Lab1_SRP.Model;



namespace SOLİDPrincibles.Lab1_SRP.BadExample
{
    public class BadStudentProcess
    {
        //Öğrencinin insert edilmesi işlemi
        public void InsertStudent(Student student)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                //1.Process => Öğrencinin modüle dahil edilmesi
                sb.Append(student.Id);            
                sb.Append(student.FullName);                
                sb.AppendLine(student.University);               
                sb.Append(student.HireDate);
                File.WriteAllText(@"C:\StudentData.txt", sb.ToString());
             
            }
            catch (Exception ex)
            {
                //2.Process => Ekleme işlemi esnasında alınacak hataların loglanması
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());              
                sb.Append("Hata Mesajı: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\StudentLog.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Hata alındı..!");
              
            }
        }
    }
}
