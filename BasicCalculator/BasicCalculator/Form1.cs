using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor of the BasicCalculator
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user unput text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments </param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Deletes the first character in the back of the cursor
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            // Delete the value before the selected position
            DeleteTextValue();
        }

        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the Divide character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("/");
        }

        /// <summary>
        /// Adds the Times character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void TimesButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("*");
        }

        /// <summary>
        /// Adds the Minus character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("-");
        }

        /// <summary>
        /// Adds the Plus character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("+");
        }

        /// <summary>
        /// Calculates the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // Calculate the equation
            CalculateEquation();
        }

        #endregion

        #region Number Methods

        /// <summary>
        /// Adds the Dot character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue(".");
        }

        /// <summary>
        /// Adds the Zero character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("0");
        }

        /// <summary>
        /// Adds the One character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("1");
        }

        /// <summary>
        /// Adds the Two character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("2");
        }

        /// <summary>
        /// Adds the Three character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("3");
        }

        /// <summary>
        /// Adds the Four character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("4");
        }

        /// <summary>
        /// Adds the Five character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("5");
        }

        /// <summary>
        /// Adds the Six character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("6");
        }

        /// <summary>
        /// Adds the Seven character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("7");
        }

        /// <summary>
        /// Adds the Eight character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("8");
        }

        /// <summary>
        /// Adds the Nine character to the text at the currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text bow at the currently selected position
            InsertTextValue("9");
        }

        #endregion

        #region Calculation methods

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            
            // Get the parsed equation and output the awnser to the text user label
            this.CalculationResultText.Text = ParseOperation(this.UserInputText.Text);

            // Focus the user input text
            FocusInputText();
        }
        
        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns>The awnser of the equation</returns>
        private string ParseOperation(string input)
        {
            // Creates new top level operation
            var operation = new Operation();
            var leftSide = true;

            try
            {
                // Remove all spaces
                input = input.Replace(" ", "");
                
                if (input.Count(t => t == '*' || t == '/' || t == '+' || t == '-') > 1)
                    // Check for needed math priority parentheses
                    input = AddParentheses(input);

                if (input.Contains("(") == true)
                    input = ParenthesesCalculation(input);

                // Loop through each character of the input
                // starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    //       4 + 5 * 3
                    //       It should calculate 5 * 3 first, then 4 + the result (so 4 + 15)
                    // Check if the current character is a number
                    if ("0123456789,.".Any(c => input[i] == c))
                    {
                        // Check what side of the operation it is
                        if (leftSide)
                            // Add the number to the left side
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            // Add the number to the ledt side
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // If it is an operator ( + - * / ) set the operator type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        // Get the operator type
                        var operatorType = GetOperationType(input[i]);

                        // If we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            // Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException("Operator (+ * / or more than one -) specified without an left side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {                               
                                // Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);
                                // Set new operator
                                operation.OperationType = operatorType;
                                // Clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            // Check if we actually have a left side number
                            if(operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException("Operator (+ * / or more than one -) specified without an left side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we got here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                // If we are done parsing, and there were no exceptions
                // calculate the current operation
                return CalculateOperation(operation);
            }
            catch(Exception ex)
            {
                return $"Invalid equation. { ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //const int MaxLength = 9;

            // Store the number values of the string representations
            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out decimal left))
                throw new InvalidOperationException($"Left side of the operation was not a number. { operation.LeftSide }");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out decimal right))
                throw new InvalidOperationException($"Right side of the operation was not a number. { operation.RightSide }");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.OperationType }");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation { operation.LeftSide } { operation.OperationType } { operation.RightSide }. { ex.Message }");
            }
        }

        /// <summary>
        /// Accepts a character and return the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknow operator type");
            }
        }

        #endregion
        

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Add the parentheses of the math priorities to the equation of a string
        /// </summary>
        /// <param name="input">The string to check for needed math priorities parentheses to add</param>
        /// <returns>A string if the added math priorities parentheses needed in the equation of the string</returns>
        private string AddParentheses(string input)
        {
            #region Initializers

            // Hold if a parentheses has been added in case of a sub-equation with the same operator 
            var addedParentheses = false;
            var lastOpenParentheses = 0;
            // To know what was the last operation that had occurred
            var lastOperation = string.Empty;
            // To know the index of the last time a expression had occurred
            var lastIndexOperation = 0;


            // To control if the expressions if parentheses was corretly closed or opened
            var countOpen = input.Count(t => t == '(');
            var countClose = input.Count(t => t == ')');

            #endregion

            #region Parentheses checker
            

            // To prevent invalid parentheses that dind't closed or opened corretly
            if (countOpen > countClose || countClose > countOpen)
                throw new InvalidOperationException("Parentheses specified without a the right closing parentheses");

            if (input.Contains("(") == true)
                input = ParenthesesCalculation(input);

            
            // Extract the content between the open and the close parentheses



                    #endregion

            #region Insert parentheses

            // Loop through each character of the input
            // starting from the left working to the right
            for (int i = 0; i < input.Length; i++)
            {
                // Look for a multiplication or a division operation on the input
                if ("*/".Any(c => input[i] == c) && i > 0)
                {
                    // Check if the last operation that had added a parentheses is not the same has now and is a multiplication operation
                    if (lastOperation != input[i].ToString() && input[i] == '*')
                    {
                        // Verify if it's time to open a parentheses
                        if (!addedParentheses)
                        {
                            // Check if it is the first time to add a parantheses in the input and if there was any other operation before,
                            // if so, then it means that it need to add the open parentheses in the beginning of the input
                            if (lastIndexOperation == 0)
                            {
                                // Insert the parentheses to the beginning of the input
                                input = input.Insert(0, "(");
                                // Hold the position of the last open parentheses added
                                lastOpenParentheses = 0;
                            }
                            else
                            {
                                // Add the a parentheses in front of the index of the last operator founded in the input
                                input = input.Insert((lastIndexOperation + 1), "(");
                                // Hold the position of the last open parentheses added
                                lastOpenParentheses = lastIndexOperation + 1;
                            }
                        }
                        // Verify if it is time to close a parentheses of a division operation
                        else if (lastOperation == "/")
                        {
                            // Insert the close parentheses behind the actual operator and close the parentheses of a division operation
                            input = input.Insert(i, ")");
                            // Then it insert a open parentheses behind the last parentheses inserted
                            input = input.Insert(lastOpenParentheses, "(");

                            // Hold that we had closed a parentheses
                            addedParentheses ^= true;
                            // Because the lenght had been incresed, the 'i' must be incresed too
                            i++;

                        }

                        // Invert the parentheses, because if we inserted a open parentheses we will need to close the next time, if needed so
                        addedParentheses ^= true;
                        // Because the lenght had been incresed, the 'i' must be incresed 
                        i++;
                    }
                    // Check if the operation now is a division
                    else if (input[i] == '/')
                    {
                        // Verify if it's time to open a parentheses
                        if (!addedParentheses)
                        {
                            // Check if it is the first parantheses in the input and if there was any other operation before,
                            // if so then it means that it need to put the open parentheses in the beginNing of the input
                            if (lastIndexOperation == 0)
                            {
                                // Insert the parentheses to the beginning of the input
                                input = input.Insert(0, "(");
                                // Hold the position of the last open parentheses added
                                lastOpenParentheses = 0;
                            }
                            else
                            {
                                // Add the a parentheses in front of the index of the last operator founded in the input 
                                input = input.Insert((lastIndexOperation + 1), "(");
                                // Hold the position of the last open parentheses added
                                lastOpenParentheses = lastIndexOperation + 1;
                            }
                        }
                        // Verify if it's time to close a parentheses
                        else
                        {
                            // Insert the close parentheses behind the actual operator and close the parentheses of the last operation
                            input = input.Insert(i, ")");
                            // Then it insert a open parentheses behind the last parentheses inserted
                            input = input.Insert(lastOpenParentheses, "(");

                            // Hold that we had closed a parentheses
                            addedParentheses ^= true;
                            // Because the lenght had been incresed, the 'i' must be incresed
                            i++;
                        }

                        // Invert the parentheses, because if we inserted a open parentheses we will need to close the next time, if needed so
                        addedParentheses ^= true;
                        // Because the lenght had been incresed, the 'i' must be incresed
                        i++;
                    }

                    // Hold the position of the actual operator
                    lastIndexOperation = i;
                    // Hold the last operation
                    lastOperation = input[i].ToString();
                }
                // Hold the value of the position, if it is a operation of minus or add, and close a parentheses if needed
                else if (input[i] == '+' || ((i != 0 && input[i] == '-') && ((lastIndexOperation + 1) != i && input[i]== '-' )))
                {
                    // If the last operation was a division or a multiplication, then it means that it need to close a parentheses
                    if (lastOperation == "/" || lastOperation == "*")
                    {
                        // Close a parentheses behind the position of the actual operator
                        input = input.Insert(i, ")");

                        // Invert the parentheses, because if we inserted a open parentheses we will need to close the next time, if needed so
                        addedParentheses ^= true;
                        // Because the lenght had been incresed, the 'i' must be incresed
                        i++;
                    }
                    // Hold the position of the actual operator
                    lastIndexOperation = i;
                    // Hold the last operation
                    lastOperation = input[i].ToString();
                }
            }

            #endregion

            #region Final checks

            // Hold the number of open and close parentheses in the string
            countOpen = input.Count(t => t == '(');
            countClose = input.Count(t => t == ')');

            // Check if the number of open parentheses is bigger than the closed parentheses
            while (countOpen > countClose)
            {
                if(lastOpenParentheses == 0)
                {
                    input = input.Remove(lastOpenParentheses, 1);
                    countOpen--;
                }
                // If the caracther behind the of the last open parentheses is a operation of minus or add, 
                // than add a close parentheses to the last position of the string
                else if ("+-".Any(c => input[lastOpenParentheses - 1] == c))
                {
                    input += ")";
                    countClose++;
                }
                // Else remove the last open parentheses
                else
                {
                    input = input.Remove(lastOpenParentheses, 1);
                    countOpen--;
                }
            }

            #endregion

            return input;
        }

        private string ParenthesesCalculation(string input)
        {
            // Look for a open parentheses in the subInput
            var lastOpenParentheses = 0;
            // Create a copy of the input to handle
            var subInput = input;

            // Remove the first and the last caracther, if the first is a open parentheses and the last is a close parentheses
            while (subInput[0] == '(' && subInput[subInput.Length - 1] == ')')
                input = subInput = subInput.Substring(1, subInput.Length - 2);

            // Look for a open parentheses
            while (input.Contains("(") == true)
            {
                // To count the lenght between a open parentheses and a close parentheses
                var parenthesesLenght = 0;

                // Look for a open and a close parentheses
                for (int i = 0; i < input.Length; i++)
                {
                    // Look for open parentheses
                    if ("(".Any(c => input[i] == c))
                    {
                        // Hold the position in front of the open parentheses 
                        lastOpenParentheses = i + 1;

                        // Restart the parentheses lenght
                        parenthesesLenght = 0;
                    }
                    // Look for close parentheses
                    else if (")".Any(c => input[i] == c))
                    {
                        // Hold the value between the open and close parentheses
                        subInput = subInput.Substring(lastOpenParentheses, parenthesesLenght);

                        // Break the for loop
                        break;
                    }
                    // Count how many caracthers are between the open parentheses and the close parentheses
                    else if (lastOpenParentheses != 0)
                        parenthesesLenght++;
                }
                
                var parsedInput = ParseOperation(subInput);
                subInput = "(" + subInput + ")";
                int replacePosition = input.IndexOf(subInput);

                // Calculate and replace the value of the input between the first open and close parentheses in a row founded first
                input = input.Remove(replacePosition, subInput.Length).Insert(replacePosition, parsedInput);
                subInput = input;
            }

            

            // Return the input if the priorities calculated
            return input;
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">New character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a Dot in the number
            if ((newCharacter == '.' && (currentNumber.Contains('.') || currentNumber.Contains(','))) || (newCharacter == ',' && (currentNumber.Contains(',') || currentNumber.Contains('.'))))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            return currentNumber + newCharacter;
        }

        /// <summary>
        /// Insert the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Delete the character to the left of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we don't have a value to delete, return
            if (this.UserInputText.SelectionStart == 0 || (this.UserInputText.SelectionStart > this.UserInputText.TextLength))
                return;

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart -1, 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection lenght to zero
            this.UserInputText.SelectionLength = 0;

            // Focus the user input text
            FocusInputText();
        }

        #endregion
    }
}