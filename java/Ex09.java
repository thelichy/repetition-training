import java.util.Scanner;

public class Ex09 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = scanner.nextInt();
        int end = scanner.nextInt();

        for (int i = start; i <= end; i += start) {
            System.out.print(i + " ");
        }

        scanner.close();
    }
}
