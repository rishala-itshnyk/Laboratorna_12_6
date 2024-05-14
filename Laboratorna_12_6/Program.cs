using System;
using System.Collections.Generic;

public class Program
{
    public struct Subscriber
    {
        public string lastName;
        public string phoneNumber;
    }

    public static Queue<Subscriber> phoneBook = new Queue<Subscriber>();

    static void Main(string[] args)
    {
        // Заповнення телефонного довідника тестовими даними
        AddSubscriber("Лисяк", "0988143937");
        AddSubscriber("Джонсонюк", "0987654321");
        AddSubscriber("Порошенко", "0983232212");

        // Друк телефонного довідника
        PrintPhoneBook();

        // Пошук абонента за прізвищем
        string lastNameToSearch = "Порошенко";
        SearchByLastName(lastNameToSearch);

        // Пошук абонента за номером телефону
        string phoneNumberToSearch = "0987654321";
        SearchByPhoneNumber(phoneNumberToSearch);
    }

    public static void AddSubscriber(string lastName, string phoneNumber)
    {
        Subscriber newSubscriber = new Subscriber { lastName = lastName, phoneNumber = phoneNumber };
        phoneBook.Enqueue(newSubscriber);
    }

    public static void PrintPhoneBook()
    {
        Console.WriteLine("Телефонний довідник:");
        Console.WriteLine("--------------------");
        Console.WriteLine("| Прізвище | Телефон |");
        Console.WriteLine("--------------------");
        foreach (var subscriber in phoneBook)
        {
            Console.WriteLine($"| {subscriber.lastName,-9} | {subscriber.phoneNumber,-8} |");
        }
        Console.WriteLine("--------------------");
    }

    public static void SearchByLastName(string lastName)
    {
        bool found = false;
        foreach (var subscriber in phoneBook)
        {
            if (subscriber.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Знайдено абонента {lastName}: {subscriber.phoneNumber}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Абонент з прізвищем {lastName} не знайдений.");
        }
    }

    static void SearchByPhoneNumber(string phoneNumber)
    {
        bool found = false;
        foreach (var subscriber in phoneBook)
        {
            if (subscriber.phoneNumber.Equals(phoneNumber))
            {
                Console.WriteLine($"Знайдено абонента з номером {phoneNumber}: {subscriber.lastName}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Абонент з номером {phoneNumber} не знайдений.");
        }
    }
}