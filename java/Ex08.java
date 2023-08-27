import java.util.Scanner;

public class Ex08 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        int end = scanner.nextInt();

        for (; end >= start; end--) {
            System.out.print(end + " ");
        }

        scanner.close();
    }
}
