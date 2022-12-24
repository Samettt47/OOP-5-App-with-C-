using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ORNEK1
            //People p = new Samet();
            //    p.canliMi();
            //People p2 = new Merve();
            //    p.canliMi();
            ////People p3 = new Masa();   HATA VERECEKTİR 
            ////    p.canliMi(); 
            #endregion

            #region ORNEK2 
            //MyClass m2 =  new MyClass2();
            //MyClass m3 = new MyClass3();

            #endregion

            #region ORNEK3 
            C c = new C();
            // c. dediğimizde tum classlardaki metotlara erişilir
            // c en kucuk cocuk old. için tüm metotlara ulasır
            B b = new C();
            // b. dediğimizde A ve B classlarında ki metotlara erişilir 
            // B c ye göre ata old için ve A da onun atası old için
            // hem kendi hem de A'nın metotlarını getirir.
            
            A a = new C();
            // a. dediğimizde sadece A daki metota ya ulaşılır . A ata olduğu içi
            // sadece kendi metodunu çağırır
            
            A a2 = new B();
            // a2. dediğimizde sadece A yı getirir. A ata olduğu için sadece
            // kendi metodunu çağırır
            
            #endregion
        }
    }

    // MYCLASS-> CUMHURBAŞKANI İSE MYCLASS 2 DE BEN İSEM BEN CUMHURBAŞKANINI REFERANS EDEMEM
    // CUMHURBASKANI BENŞ REFERANS EDER


    #region ORNEK 1
    //class People
    //{
    //    public void  canliMi()
    //    {
    //        Console.WriteLine("ben canlıyım... ");
    //    }
    //}
    //class Samet : People
    //{

    //}
    //class Merve : People
    //{

    //}
    //class Masa
    //{

    //} 
    #endregion

    #region ORNEK2 
    //class MyClass
    //{

    //}
    //class MyClass2 : MyClass
    //{

    //}
    //class MyClass3 : MyClass
    //{

    //}
    #endregion

    #region ORNEK3 

    class A
    {
        public void X() { }
    }
    class B : A
    {
        public void Y() { }
    }
    class C : B
    {
        public void Z() { }
    }
    #endregion
}
