// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;

namespace Coding.Exercise{

    class Contact{

        // solution
        public string Name { get; set; }
        public string Phone { get; set; }

        public void Call(){
            System.Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
        }

        public Contact(string name, string phone){
            Name = name;
            Phone = phone;
        }
        // solution
    }

    class PhoneBook: IEnumerable<Contact>{
        
        public List<Contact> Contacts;
        
        public PhoneBook(){
            Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }
        // solution


        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator(){
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator(){
            throw new NotImplementedException();
        }
        // solution
    }
   

    public static class Program{
        static public void Main(string[] args){
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook){
                contact.Call();
            }
        } 
    }

}