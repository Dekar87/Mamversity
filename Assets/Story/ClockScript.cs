﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClockScript : MonoBehaviour {

	private float starting_time;
	private float last_update;
	public Text text;
	public GlobalVariables globalVariables;

	// Use this for initialization
	void Start () {
		globalVariables = new GlobalVariables ();
	}
	
	// Update is called once per frame
	void Update () {
		float time = Time.time;
		if(last_update + 1 <= time){
			float sec = globalVariables.getTime().sec;
			int min = globalVariables.getTime().min;
			int hour = globalVariables.getTime().hour;
			int day = globalVariables.getTime().day;
			int season = globalVariables.getTime().season;
			int year = globalVariables.getTime().year;

			String sec_string, min_string, hour_string, day_string, season_string, year_string;

			sec_string = sec.ToString ();
			min_string = min.ToString ();
			hour_string = hour.ToString ();
			day_string = day.ToString ();

			if (sec < 10) {
				sec_string = '0' + sec_string;
			}

			if (min < 10) {
				min_string = '0' + min_string;
			}

			if (hour < 10) {
				hour_string = '0' + hour_string;
			}

			if (day < 10) {
				day_string = '0' + day_string;
			}

			switch (season) {
			case (int) Seasons.WINTER:
				season_string = "Winter";
				break;
			case (int) Seasons.SPRING:
				season_string = "Spring";
				break;
			case (int) Seasons.SUMMER:
				season_string = "Summer";
				break;
			default:
				season_string = "Fall";
				break;
			}

			year_string = year.ToString ();

			text.text = year_string + ", " + season_string + " " + day_string + "\n" + hour_string+ " : " + min_string+ " : " + sec_string;
			last_update = time;
		}
	}
	void FixedUpdate(){
	}
}
