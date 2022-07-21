// See https://aka.ms/new-console-template for more information
using คุก;
using System.Linq;
Console.WriteLine("Hello, World!");

var coreL = new CoreLogic();
var input = new CoreLogic.CoreInput();
input.inputVal1="Initial no output value";
var serviceResult = new CoreLogic.CoreOutput("");

// Original Core Logic 
    serviceResult = coreL.DoOperaton(input);
    Console.WriteLine("Initial CoreLogic : " + serviceResult.outValue);

#region Test : ขอเซ็ทหย่อ 
// Test : ขอเซ็ทหย่อ using v0.2  
Console.WriteLine("Test : ขอเซ็ทหย่อ using v0.2");
    var นักโทษ = new คนคุก(coreL);
    input.inputVal1 ="แล้วคุณจะรู้มั้ย ว่าเค้าจะเล่นคุณ!";
    // #1   
    var ไข่1  = input ;
    serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่1);
    Console.WriteLine("   #1 : " + serviceResult.outValue);
    // #2 
    Action<CoreLogic.CoreInput> UwU =  
     ( x )   => { var ไข่2 = x; serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่2); };
    UwU(ไข่1); 
    Console.WriteLine("   #2 : " + serviceResult.outValue);
    // #3
    Func< CoreLogic.CoreInput, CoreLogic.CoreOutput> tempF =
     ( x ) => { var ไข่3 = x; return นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่3);};
    Console.WriteLine("   #3 : " + tempF(ไข่1).outValue );

#endregion


Console.WriteLine("End Test");
