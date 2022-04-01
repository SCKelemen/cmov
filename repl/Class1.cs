namespace repl;
public class Repl
{   
    private readonly string prompt = ">> ";
    public Repl(string prompt) {
        this.prompt = prompt;
    }
    public Repl() {

    }

    public void Run() {
        for(;;) {
            print(eval(read())); 
        }
    }

    private string read() {
        System.Console.Write(this.prompt);
        return System.Console.ReadLine();
    }
    private string eval(string input) {
        input = input.ToLower();
        if (input == "quit" || input == "exit") {
            quit("Bye!");
        }  

        var parsed = parse(input);
        var output = input switch {
            "move" => 
        }

        return input;
    }
    private void print(string message) {
        System.Console.WriteLine(message);
    }

    private void quit(string message) {
        print(message);
        System.Environment.Exit(0);
    }

}

public class Parser {

    public Parser(string input) {
        
    }

    public string Parse() {

    }
}

// tokens 
// cancel move copy
public class Token {

}