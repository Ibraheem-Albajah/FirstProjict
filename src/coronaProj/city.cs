using System; 
using System.Collections.Generic; 
  
class city{
public String name ; 
public int population;
public int numberOfAvtice ;
public int numberOfDeath;
public int numberOfHospital ;
public int id ;

public city(String name  ,int population , int numberOfAvtice ,int numberOfDeath ,int numberOfHospital ){
this.name = name;
this.population = population;
this.numberOfAvtice = numberOfAvtice;
this.numberOfDeath = numberOfDeath ; 
this.numberOfHospital=numberOfHospital;

}
public city(String name  ,int population , int numberOfAvtice ,int numberOfDeath ,int numberOfHospital , int id ){
this.name = name;
this.population = population;
this.numberOfAvtice = numberOfAvtice;
this.numberOfDeath = numberOfDeath ; 
this.numberOfHospital=numberOfHospital;
this.id=id;

}
public String getName() => name ;
    public int getid() => id ;



    public int getpopulation() => population;

    public String print(){



 return $"name : {name} , Population {population} , Number of active cass {numberOfAvtice}, number of death cass {numberOfDeath}, Number of Hospital {numberOfHospital} " ;  
}




}