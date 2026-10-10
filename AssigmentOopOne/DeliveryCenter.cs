using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOopOne
{//part 2 q5 
    internal struct DeliveryCenter
    {
       
       
            private Shipment[] shiments = new Shipment[10];

            public DeliveryCenter()
            {

            }
            public Shipment this[int shi]
            {
                get
                {
                    if (shi >= 0 && shi < 10)


                        return shiments[shi];
                    return default;

                }
                set
                {
                    if (shi >= 0 && shi < 10)
                    {
                        shiments[shi] = value;
                    }
                }
            }
            public Shipment this[string code]
            {
                get
                {
                    for (int i = 0; i < shiments.Length; i++)
                    {
                        if (shiments[i].TrackingCode == code)
                        {
                            return shiments[i];
                        }
                    }
                    return default;
                }
            }


            public bool AddShipment(Shipment s)
            {
                for (int i = 0; i < shiments.Length; i++)
                {
                    if (shiments[i].Equals(default(Shipment)))
                    {
                        shiments[i] = s;
                        Console.WriteLine("the shipment is added  succsesfely");
                        return true;
                    }
                }
                return false;


            }







        }
    }



