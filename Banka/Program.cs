namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService dataBaseLoggerService=new DataBaseLoggerService();

            ILoggerService fileLoggerService=new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager,ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}