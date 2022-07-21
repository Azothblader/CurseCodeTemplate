// See https://aka.ms/new-console-template for more information

namespace คุก;
/*
//v0.2 
// + Class name คนคุก relate to namespace คุก
// + Prevent to use Core Class 's method if the word is not call in order :  ขอเซ็ทหย่อ>สู่ต่อ>ซูดผ่อ>ซีหม่อ>สองห่อ>ใส่>ไข่
// + Make asshole image somewhere
//Example how to use the template

var coreL = new CoreLogic();
var input = new CoreLogic.CoreInput();
var serviceResult = new CoreLogic.CoreOutput("");

    // #1   
    var ไข่1  = input ;
    serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่1);
    Console.WriteLine("#1 : " + serviceResult.outValue);
    // #2 
    Action<CoreLogic.CoreInput> UwU =  
     ( x )   => { var ไข่2 = x; serviceResult = นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(ไข่2); };
    UwU(ไข่1); 
    Console.WriteLine("#2 : " + serviceResult.outValue);

    //#3
    Func< CoreLogic.CoreInput, CoreLogic.CoreOutput> tempF =
     ( x ) => {return นักโทษ.ขอเซ็ทหย่อ.สู่ต่อ.ซูดผ่อ.ซีหม่อ.สองห่อ.ใส่(x);};
    Console.WriteLine("#3 : " + tempF(ไข่1).outValue );

 

*/



public class คนคุก
{ 
    protected CoreLogic RealLogic { get; set; }
    protected bool Active { get; set; }

    public CoreLogic.CoreOutput ใส่(CoreLogic.CoreInput input)
    {
        if (Active)
        {
            var o = RealLogic.DoOperaton(input);
            o.outValue = "แล้วคุณจะรู้มั้ย ว่าเค้าจะเล่นคุณ!";
            return o;
        }
        else
        {
            throw new Exception("Invalid Operation");
        }
    }

    public คนคุก()
    {
        //ขอเซ็ทหย่อ = new Dummy(this);
        _ขอเซ็ทหย่อ = this;
    }
    public คนคุก(CoreLogic d) : base()
    {
        RealLogic = d;
    }
 


#region Nothing to do here
    private คนคุก _ขอเซ็ทหย่อ;
    public คนคุก ขอเซ็ทหย่อ
    {
        get
        {
            _ขอเซ็ทหย่อ = this;
            _สู่ต่อ = this;
            _ซูดผ่อ = _ซีหม่อ = _สองห่อ = null;
            Active = false;
            return _ขอเซ็ทหย่อ;
        }
        set { _ขอเซ็ทหย่อ = value; }
    }
    private คนคุก _สู่ต่อ;
    public คนคุก สู่ต่อ
    {
        get
        {
            _ซูดผ่อ = this;
            _ขอเซ็ทหย่อ = _ซีหม่อ = _สองห่อ = null;
            Active = false;
            return _สู่ต่อ;
        }
        set { _สู่ต่อ = value; }
    }
    private คนคุก _ซูดผ่อ;
    public คนคุก ซูดผ่อ
    {
        get
        {
            _ซีหม่อ = this;
            _ขอเซ็ทหย่อ = _สู่ต่อ = _สองห่อ = null;
            Active = false;
            return _ซูดผ่อ;
        }
        set { _ซูดผ่อ = value; }
    }
    private คนคุก _ซีหม่อ;
    public คนคุก ซีหม่อ
    {
        get
        {
            _สองห่อ = this;
            _ขอเซ็ทหย่อ = _สู่ต่อ = _ซูดผ่อ = null;
            Active = false;
            return _ซีหม่อ;
        }
        set { _ซีหม่อ = value; }
    }
    private คนคุก _สองห่อ;
    public คนคุก สองห่อ
    {
        get
        {
            _ขอเซ็ทหย่อ = _สู่ต่อ = _ซูดผ่อ = null;
            Active = true;
            return _สองห่อ;
        }
        set { _สองห่อ = value; }
    }

#endregion

}
 
