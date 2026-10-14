namespace AssigmentOopOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 q1
            //answer 1 
            //method overliading : يعني اي بعمل فانكشن بنفس اسم فانكشن عندي بس بغير فى عدد البراميتر او ترتيبهم
                 //او النوع بتاعهم بييحصل عادي لو فى وراثه او مفيش مش معتمد اصلا على ولااثه
                //method overriding :دي فانكشن انا  بورثها بس بغير فى سلوكها 
                //staticbyding :بيحصل  فى وقت الكومبلي تايم
                //dynamicbuding:بيحصل وقت الكومبيل
            #endregion
            #region part1 q2

            //A:acces modifer public: ليها عده مشاكل 
            //عدم وجود طبقه حمايه على الfield اي حد يقدر يستخدمها فى اي مكان 
            //ممكن يحصل تداخل بسبب ان اسم الfield موجود فى اكتر من كلاس مثلا 
            //محميتش الfield من  devoloper الى شغال معايا لانه ممكن يستخدمها بالغلط
            //عند التغيير فى اسم الfield بتضطر اغيرها فى اي مكان استخطمته ولو الكود كتير يبقي ده صعب
            //صعوبه عمل valdation عليها
            //b:private:كده هبقي مطمن ان حميتها من اي خطا ممكن يحصل بدون قصد
            //كمان هستخدم الget&setوده هيبقي منظم اكتر واقدر كمان اعمل valdation فى نفس السطر
            //حميتها من ان يحصل تعارض بينها وبين field فى كلاس تاني بسبب تشابهه الاسماء


            #endregion
            DeliveryAddress d1 = new DeliveryAddress("mansoura", "Glaa", 43);
            DeliveryAddress d2 = d1;
            Console.WriteLine(d1.GetFullAdress());
            Console.WriteLine(d2.GetFullAdress());
            d2.setCity("cairo");
            d2.setStreet("Ahmed Araby");
            d2.setBuldingNum(88);
            Console.WriteLine(d1.GetFullAdress());
            Console.WriteLine(d2.GetFullAdress());
            Shipment s = new Shipment("1445", "this is skin care", 30, 150, d1);
            s.TrackingCode = "12345";
            s.Descrption = "this is a clothes";
            s.Weight = 20;
            s.destination.GetFullAdress();
            Console.WriteLine(s.PrintShipment());

            DeliveryCenter deliveryCenter1 = new DeliveryCenter();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please Enter Tracking Code : ");
                string tcode = Console.ReadLine();
                Console.WriteLine("Please Enter Descrption");
                string descraption = Console.ReadLine();
                Console.WriteLine(" please enter Weigth");
                double weigth = double.Parse(Console.ReadLine());
                Console.WriteLine("please Enter deliveryFee");
                double deliveryFee = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter destination");
                DeliveryAddress des = new DeliveryAddress();
                Console.WriteLine("please enter your city: ");
                des.setCity(Console.ReadLine());
                Console.WriteLine("please Enter your street : ");
                des.setStreet(Console.ReadLine());
                Console.WriteLine("please Enter buliding num : ");
                des.setBuldingNum(int.Parse(Console.ReadLine()));
                Shipment si = new Shipment(tcode, descraption, weigth, deliveryFee, des);
                deliveryCenter1.AddShipment(si);

            }
            Console.WriteLine(deliveryCenter1[0]);
            Console.WriteLine(deliveryCenter1[1]);
            Console.WriteLine(deliveryCenter1[2]);
            Console.WriteLine("please enter your tracking code to search");
            Console.WriteLine("please enter the tracking code to search :");

            string? trackingCode = Console.ReadLine();

            object value = deliveryCenter1[trackingCode];
        }
    }
}
