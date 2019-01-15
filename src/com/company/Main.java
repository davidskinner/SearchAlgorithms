package com.company;

public class Main {


    public static int linearSearch(int[] intArray, int value)
    {
        for (int i = 0; i < intArray.length; i++)
        {
            if(intArray[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public static void main(String[] args) {

        int val = 9;
        int[] A =  {2,1,4,5,6,3};

        System.out.println(linearSearch(A,val));
    }
}
