using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Pages.Learn_Blazor
{
    public partial class LearnBlazor : ComponentBase
    {
        protected string name = "Spark";
        protected string WelcomeText = "Stiamo imparando Blazor!";

        protected void getName()
        {
            name = "Blazor Learner";
        }

    }
}
