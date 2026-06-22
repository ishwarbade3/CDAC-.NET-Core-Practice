namespace India;

internal class Class3 : Class2
{

    public Class3()
    {
        Class3 c = new Class3();
        int a = c.PublicA;
        a = c.ProtectedC;
        a = c.InternalD;
        a = c.ProtectedInternalE;
    }
  
}
