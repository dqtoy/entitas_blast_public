﻿public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts) : base("View Systems")
    {
        Add(new AddViewPoolSystem(contexts));
    }
}