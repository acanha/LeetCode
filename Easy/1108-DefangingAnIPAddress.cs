/*
    Given a valid (IPv4) IP address, return a defanged version of that IP address.
    A defanged IP address replaces every period "." with "[.]".
 
 */

public class Problem1108
{
    public string Solution(string address)
    {
        return address.Replace(".", "[.]");
    }
}

