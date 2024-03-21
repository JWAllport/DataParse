using System;
using CsvHelper.Configuration.Attributes;


[Obsolete] // transitioned to using dynamic type when reading data from file. 
public class Customer {

    // Index,Customer Id,First Name,Last Name,Company,City,Country,
    // Phone 1,Phone 2,Email,Subscription Date,Website

    [Name("Index")]
    public string index {get; set;}
    
    [Name("Customer Id")]
    public string customerID  {get; set;}
    
    [Name("First Name")]
    public string fName  {get; set;}
    
    [Name("Last Name")]
    public string lName  {get; set;}
    
    [Name("Company")]
    public string company  {get; set;}
    
    [Name("City")]
    public string city  {get; set;}
    
    [Name("Country")]
    public string country  {get; set;}
    
    [Name("Phone 1")]
    public string phone1  {get; set;}
    [Name("Phone 2")]
    public string phone2  {get; set;}
    
    [Name("Email")]
    public string email  {get; set;}
    
    [Name("Subscription Date")]
    public DateOnly subDate  {get; set;}
    
    [Name("Website")]
    public string website  {get; set;}

}