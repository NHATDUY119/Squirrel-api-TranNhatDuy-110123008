package com.math;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class AppTest {
    App app = new App();

    @Test
    public void testVoSoNghiem() {
        // Trường hợp a = 0, b = 0
        assertEquals("VSN", app.giaiPhuongTrinhBac1(0, 0));
    }

    @Test
    public void testVoNghiem() {
        // Trường hợp a = 0, b != 0
        assertEquals("VN", app.giaiPhuongTrinhBac1(0, 5));
    }

    @Test
    public void testCoNghiem() {
        // Trường hợp a != 0
        assertEquals("CN: -2.0", app.giaiPhuongTrinhBac1(2, 4));
    }
}