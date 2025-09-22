using System;

public class Cometa : DI_EX7.Astro, DI_EX7.ITerraformable
{
    public Cometa()
    {
    }

    public bool esHabitable()
    {
        return false;
    }
}
