namespace FormShop.View
{
    public static class FormController
    {
        public static void Start(string formName)
        {
            forms?.Where(x => x.Name.Equals(formName)).FirstOrDefault()?.ShowDialog();
        }

        public static void Add(Form form) => forms.Add(form);
        public static Form GetFirst() => forms.FirstOrDefault();
        public static Form GetErrorForm() => errorForm;
        public static void SetErrorForm(Form form) => errorForm = form;

        static List<Form> forms = new List<Form>();

        static Form errorForm;
    }
}
