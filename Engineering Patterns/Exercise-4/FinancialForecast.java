public class FinancialForecast {

    public static double futureValue(double principal, double rate, int years) {
        if (years == 0) return principal;
        return futureValue(principal, rate, years - 1) * (1 + rate);
    }

    public static void main(String[] args) {
        double principal = 10000;
        double growthRate = 0.05;
        int periods = 5;

        double result = futureValue(principal, growthRate, periods);
        System.out.printf("Future Value after %d years: %.2f%n", periods, result);
    }
}
