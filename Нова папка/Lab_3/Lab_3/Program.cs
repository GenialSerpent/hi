
/*Об’єкт “Автомобіль” (використати члени - класи)
поля, марка;
відомості про виробника  (член-клас) (назва фірми, рік заснування, номер телефону, обсяги виробництва);
відомості про продавця (член-клас) (назва фірми, рік заснування, номер телефону, обсяги продажу);
відомості про власника (член-клас) (прізвище та ініціали, ідентифікаційний код)
колір;
номер;
дата випуску(член-клас);*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    struct Data_1
    {
        public string Firm { get; set; }
        public DateTime YearOfFoundatson { get; set; }
        public string PhoneNumber { get; set; }
        public double Volume { get; set; }
        public Data_1(string firm, DateTime yearOfFoundatson, string phoneNumber, double volume)
        {
            Firm = firm;
            YearOfFoundatson = yearOfFoundatson;
            PhoneNumber = phoneNumber;
            Volume = volume;
        }
        public override string ToString()
        {
            string str;
            if (Volume >= 1000)
            {
                Volume /= 1000;
                str = "тис.";
            }
            else if (Volume >= 1000000)
            {
                Volume /= 1000000;
                str = "млн.";
            }
            else
                str = "";
            return $"{Firm}, рік заснування - {YearOfFoundatson}, номер телефону - {PhoneNumber}, обсяг - {Volume:f2} {str}";
        }
    }
    struct Data_2
    {
        public string Surname { get; set; }
        public string Code { get; set; }
        public Data_2(string surname, string code)
        {
            Surname = surname;
            Code = code;
        }
        public override string ToString()
        {
            return $"{Surname}, ідентифікаційний код - {Code}";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var maker = new Data_1("Bayerische Motoren Werke AG", new DateTime(1916, 3, 7), "0501367264", 2372059);
            var seler = new Data_1("BMW АЛЬЯНС ПРЕМІУМ", new DateTime(2008, 8, 21), "0800994876", 11591);
            var owner = new Data_2("Галан Л. М.", "002597513");

            Car car = new Car("BMW", maker, seler, owner, "black", "AW 9507 DR", new DateTime(2019, 7, 16));
            Console.WriteLine($"Автомобіль: {car}");

            int yearOfCar = car.YearOfCar(2021);
            Console.WriteLine($"Вік автомобіля: {yearOfCar}");

            Console.Read();
        }
    }

    internal class Car
    {
        public string Mark { get; set; }
        public Data_1 Maker { get; set; }
        public Data_1 Seler { get; set; }
        public Data_2 Owner { get; set; }
        public string Color { get; set; }
        public string CarNumber { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Car(string mark, Data_1 maker, Data_1 seler, Data_2 owner, string color, string carNumber, DateTime releaseDate)
        {
            Mark = mark;
            Maker = maker;
            Seler = seler;
            Owner = owner;
            Color = color;
            CarNumber = carNumber;
            ReleaseDate = releaseDate;
        }
        public override string ToString()
        {
            return $"марка - {Mark}, виробник: {Maker}; продавець: {Seler}; власник: {Owner}; колір - {Color}, номер - {CarNumber}, дата випуску - {ReleaseDate}.";
        }
        public int YearOfCar(int presentYear)
        {
            return presentYear - ReleaseDate.Year;
        }

    }
}