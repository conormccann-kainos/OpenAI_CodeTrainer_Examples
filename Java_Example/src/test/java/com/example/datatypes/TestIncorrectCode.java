java
import org.junit.Test;
import static org.junit.Assert.*;

public class TestIncorrectCode {
    @Test
    public void testIncorrectCode() {
        IncorrectCode ic = new IncorrectCode();
        assertEquals(ic.num, 10);
        assertEquals(ic.str, "Hello");
        assertEquals(ic.bool, true);
        assertEquals(ic.arr.length, 5);
        assertEquals(ic.ch, 'A');
        assertEquals(ic.b, 128);
    }
}
