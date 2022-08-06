namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackredi = new IhtiyacKrediManager();
            IKrediManager tasitkredi=new TasitKred_Manager();
            IKrediManager konutkredi = new KonutKrediManager();

            BasvuruManager basvuru = new BasvuruManager();
            ILoggerService fileloggerservice = new FileLoggerService();
            basvuru.BasvuruYap(ihtiyackredi,new DatabaseLoggerService());
            List<IKrediManager> list = new List<IKrediManager>() {tasitkredi,ihtiyackredi };
            //basvuru.KrediOnBilgilendirmesiYap(list);
            ILoggerService databaselogger;
        }
    }
}