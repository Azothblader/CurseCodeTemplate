// See https://aka.ms/new-console-template for more information

namespace คุก;
 
//v0.1
//Example how to use the template
/*
var ไข่ = new RealParameter();
var serviceResult =  ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่);

Console.WriteLine(serviceResult);

*/

public class ขอเซ็ทหย่อ{
    public static A สู่ต่อ = new A(); 
}
public class A{
  public B ซูดผ่อ{get;set;}
   public  A(){
        ซูดผ่อ = new B();  
   } 

}
public class B{
  public C ซีหม่อ{get;set;}
   public  B(){
        ซีหม่อ = new C();  
   } 

}
public class C{
     public XService สองห่อ{get;set;}
   public C (){
        สองห่อ = new XService();  
   } 
}
public class XService{
  public string ใส่(object o ){

    return "คุณจะรู้มั้ย ว่าเค้าจะเล่นคุณ!";
  }

}
 
