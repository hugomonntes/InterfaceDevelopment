using System;

public class Cometa : Astro, ITerraformable
{
    public Cometa()
    {
        bool ITerraformable.esHabitable()
        {
            return false;
        }
    }
}
