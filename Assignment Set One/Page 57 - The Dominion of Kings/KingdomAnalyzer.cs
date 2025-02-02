// Written By: Patrick Leonard
// 2/1/25

namespace Page_57___TheDominionOfKings;

using System;

public class KingdomAnalyzer
{
	// Constants
	private const int ESTATE_POINT_VALUE   = 1;
	private const int DUCHY_POINT_VALUE    = 3;
	private const int PROVINCE_POINT_VALUE = 6;


	// Backing Fields
	private int numberOfEstates;
	private int numberOfDuchies;
	private int numberOfProvinces;


	// Gets and Sets
	public int NumberOfEstates
	{
		get => numberOfEstates;
		set => numberOfEstates = AssertPositive(value);
	}

	public int NumberOfDuchies
	{
		get => numberOfDuchies;
		set => numberOfDuchies = AssertPositive(value);
	}

	public int NumberOfProvinces
	{
		get => numberOfProvinces;
		set => numberOfProvinces = AssertPositive(value);
	}


	// Calculated Properties
	public int EstateScoreComponent
	{
		get => NumberOfEstates * ESTATE_POINT_VALUE;
	}

	public int DuchyScoreComponent
	{
		get => NumberOfDuchies * DUCHY_POINT_VALUE;
	}

	public int ProvinceScoreComponent
	{
		get => NumberOfProvinces * PROVINCE_POINT_VALUE;
	}

	public int TotalScore
	{
		get => EstateScoreComponent + DuchyScoreComponent + ProvinceScoreComponent;
	}
	

	// Constructors
	public KingdomAnalyzer(int numEstates, int numDuchies, int numProvinces)
	{
		NumberOfEstates   = numEstates;
		NumberOfDuchies   = numDuchies;
		NumberOfProvinces = numProvinces;
	}

	public KingdomAnalyzer() : this(0,0,0) { }


	// Methods
	private static int AssertPositive(int num)
	{
		if (num < 0) throw new ArgumentOutOfRangeException(nameof(num), "Value cannot be less than zero.");
		return num;	
    }

    public override string ToString()
    {
		return $"""
			Kingdom Analyzer:
			  Estate   - Quantity: {NumberOfEstates} Score: {EstateScoreComponent}
			  Duchy    - Quantity: {NumberOfDuchies} Score: {DuchyScoreComponent}
			  Province - Quantity: {NumberOfProvinces} Score: {ProvinceScoreComponent}
			  ------------
			  Total Score: {TotalScore}
			""";
    }
}
