using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student 
{

    public int Id{get;set;}
    [StringLength(15)]
    public string Naam{get;set;}
    [StringLength(15)]
    public string Achternaam{get;set;}
    [Range(0,110)]
    public int Leeftijd{get;set;}
    [Required]
    public string Woonplaats{get;set;}
    [Range(0,240)]
    public int Lengte{get;set;}
     public List <Student> Vrienden{get;set;}
}