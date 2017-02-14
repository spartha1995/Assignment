package calculator.promact.com.calculatorapp;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.Stack;

public class MainActivity extends AppCompatActivity {

    private TextView display, displayResult;
    private String displayString = "";

    private Stack<Integer> numberStack;
    private Stack<Character> operatorStack;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        numberStack = new Stack<>();
        operatorStack = new Stack<>();

        display = (TextView) findViewById(R.id.display);
        displayResult = (TextView) findViewById(R.id.display_result);


    }

    public void keyPressed(View view) {
        Button button = (Button) view;

        String key = button.getText().toString();

        if(displayString.equals("0")){
            displayString = "";
        }

        if(!displayString.isEmpty() && displayString.charAt(displayString.length()-1) == '='){
            displayString = "";
        }


        switch (key){
            case "1":  displayString += "1";
                break;
            case "2":  displayString += "2";
                break;
            case "3":  displayString += "3";
                break;
            case "4":  displayString += "4";
                break;
            case "5":  displayString += "5";
                break;
            case "6":  displayString += "6";
                break;
            case "7":  displayString += "7";
                break;
            case "8":  displayString += "8";
                break;
            case "9":  displayString += "9";
                break;
            case "0":  displayString += "0";
                break;
            case "+":  displayString += "+";
                break;
            case "-":  displayString += "-";
                break;
            case "C":  displayString = "0";
                displayResult.setText("");
                break;
            case "=":
                displayResult.setText(Integer.toString(solve()));
                break;
        }

        display.setText(displayString);
    }

    private int solve() {
        parseDisplayString();

        int number = 0, result = 0;
        char operator = ' ';
        if(!numberStack.empty()){
            result = numberStack.pop();
        }

        while(!operatorStack.empty()){

            number = numberStack.pop();
            operator = operatorStack.pop();

            Log.d("CALAPP", "Operator : "+operator+" | "+result+" "+operator+" "+number);

            switch(operator){
                case '+': result += number;
                    break;
                case '-': result = number - result;
                    break;
            }



        }

        Log.d("CALAPP", "NumberStackSize : "+numberStack.size());
        Log.d("CALAPP", "OperatorStackSize : "+operatorStack.size());
        Log.d("CALAPP", "Result : "+result);


        return result;
    }

    private void parseDisplayString() {
        String numberAsString = "";
        int number = 0, result = 0, i = 0;

        if(displayString.isEmpty())
            displayString += "0";

        displayString += "=";

        while(displayString.charAt(i) != '='){
            if(displayString.charAt(i) != '+' && displayString.charAt(i) != '-')
                numberAsString += displayString.charAt(i);
            else{
                number = Integer.parseInt(numberAsString);
                numberAsString = "";
                numberStack.push(number);
                operatorStack.push(displayString.charAt(i));
            }
            i++;
        }

        number = Integer.parseInt(numberAsString);
        numberStack.push(number);
    }
}
