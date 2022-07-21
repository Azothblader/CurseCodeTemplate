// See https://aka.ms/new-console-template for more information
using คุก;
using System.Linq;
Console.WriteLine("Hello, World!");

var coreL = new CoreLogic();
var input = new CoreLogic.CoreInput();
var serviceResult = new CoreLogic.CoreOutput("");


// Test : ขอเซ็ทหย่อ using v0.2  
    var นักโทษ = new คนคุก(coreL);
    // #1   
    var ไข่1  = input ;
    serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่1);
    Console.WriteLine("#1 : " + serviceResult.outValue);
    // #2 
    Action<CoreLogic.CoreInput> UwU =  
     ( x )   => { var ไข่2 = x; serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่2); };
    UwU(ไข่1); 
    Console.WriteLine("#2 : " + serviceResult.outValue);

    // #3
    Func< CoreLogic.CoreInput, CoreLogic.CoreOutput> tempF =
     ( x ) => {return นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(x);};
    Console.WriteLine("#3 : " + tempF(ไข่1).outValue );


Console.WriteLine("End Test");
