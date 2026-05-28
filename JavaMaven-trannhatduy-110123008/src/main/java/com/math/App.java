package com.math;

public class App {
    public String giaiPhuongTrinhBac1(double a, double b) {
        if (a == 0) {
            if (b == 0) {
                return "VSN";
            }
            return "VN";
        }
        return "CN: " + (-b / a);
    }
}