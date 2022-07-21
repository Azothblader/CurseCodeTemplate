//namespace mainProgram;

public class CoreLogic
{
    InjectionObj dummy { get; set; }
    public CoreLogic(InjectionObj d)
    {
        dummy = d;
    }
    public CoreLogic()
    {
        dummy = new InjectionObj();

    }
    public CoreOutput DoOperaton(CoreInput i){

        return new CoreOutput("");
    }


    #region related object
    public class InjectionObj
    {
        // e.g. EF ??
    }

    public class CoreInput
    {
        public string inputVal1 { get; set; }
        public string inputVal2 { get; set; }

    }
    public class CoreOutput
    {
        public CoreOutput(string i){ outValue=i;}
        public string outValue { get; set; }

    }
    #endregion

}