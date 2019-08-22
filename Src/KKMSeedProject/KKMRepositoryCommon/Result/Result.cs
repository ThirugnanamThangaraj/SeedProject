namespace KKM.Repository.Common.Result
{
    public class Result : Result<object>
    {
        public Result(bool isValid) : base(isValid)
        {
        }

        public Result(bool isValid, string errorMessage) : base(isValid, errorMessage)
        {
        }

        public Result(bool isValid, object value) : base(isValid, value)
        {
        }

        public Result(bool isValid, object value, string errorMessage) : base(isValid, value, errorMessage)
        {
        }
    }




        public class Result<T>
        {
            public bool IsValid
            {
                get;
                private set;
            }

            public T Value
            {
                get;
                private set;
            }

            public string ErrorMessage
            {
                get;
                set;
            }

            public Result(bool isValid)
            {
                this.IsValid = isValid;
            }

            public Result(bool isValid, string errorMessage)
            {
                this.IsValid = isValid;
                this.ErrorMessage = errorMessage;
            }

            public Result(bool isValid, T value)
            {
                this.IsValid = isValid;
                this.Value = value;
            }

            public Result(bool isValid, T value, string errorMessage)
            {
                this.IsValid = isValid;
                this.Value = value;
                this.ErrorMessage = errorMessage;
            }
        }
    }


