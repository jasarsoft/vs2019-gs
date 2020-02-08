using System;

namespace LoanCalculator.Core.Domain
{
    public class LoanSizeLoanApprovalRule : ILoanQualificationRule
    {


        public const String RULE_NAME = "Loan Size";
        private const int MIN_LOAN = 50_000;
        private const int MAX_LOAN = 1_000_000;

        public string RuleName { get => RULE_NAME; }

        public bool CheckLoanApprovalRule(LoanApplication application)
        {
            var loanAmount = application.LoanAmount;
            double amountTripled = loanAmount * 3;


            if (loanAmount > MIN_LOAN && loanAmount < MAX_LOAN)
            {
                // Loans from $50,000 to $1,000,000 are OK
                return true;
            }

            return false;
        }
    }


}

