using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOopOne
{
    internal class Shipment
    {
     //part2 q2
            private string trackingCode;
            private string descrption;
            private double weight;
            private double deleiveryFee;
            public DeliveryAddress destination { get; set; }
            // q3 constractor overloding
            public Shipment(string t)
            {
                trackingCode = t;
                descrption = "unknow";
                weight = 1;
                deleiveryFee = 50;
                destination = new DeliveryAddress();
            }
            public Shipment(string t, string d, double i, double de, DeliveryAddress delive)
            {
                trackingCode = t;
                descrption = d;
                weight = i;
                deleiveryFee = de;
                destination = delive;
            }
            //
            public string TrackingCode
            {
                get
                {
                    return trackingCode;
                }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        trackingCode = value;
                    }
                }

            }
            public string Descrption
            {
                get
                {
                    return descrption;
                }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        descrption = value;

                    }
                }

            }
            public double Weight
            {
                get
                {
                    return weight;
                }
                set
                {
                    if (Weight > 0)
                    {
                        weight = value;
                    }
                }
            }
            public double DeleiveryFee
            {
                get
                {
                    return deleiveryFee;
                }
                private set
                {
                    if (DeleiveryFee > 0)
                    {
                        deleiveryFee = value;
                    }
                    deleiveryFee = 150;
                }

            }
            public double EstimatedCost
            {
                get
                {
                    return DeleiveryFee + (weight * 5);
                }


            }//answer 4
            public void UpdateDeliveryFee(decimal newfee)
            {
                if (newfee > 0)
                {
                    deleiveryFee = (double)newfee;
                }

            }
            public string PrintShipment()
            {
                return $" the code: {TrackingCode} the descrabtion : {Descrption} weigth  : {Weight} delivery cost : {DeleiveryFee} cost: {EstimatedCost}";
            }

        }
    }



