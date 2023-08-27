import java.util.Scanner;


public class Ex31 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        long num = scanner.nextLong();
        int dig = scanner.nextInt();
        int len = getLongLength(num);
        int occ = 0;

        for (long i = (long) Math.pow(10, len - 1); i > 0; i /= 10) {
            int n = (int) (num / i % 10);
            if (n == dig) {
                occ++;
            }
        }

        System.out.println(occ);
        scanner.close();
    }

    static int getLongLength(long num) {
        int len = 0;

        while (num > 0) {
            num /= 10;
            len++;
        }

        return len;
    }
}
