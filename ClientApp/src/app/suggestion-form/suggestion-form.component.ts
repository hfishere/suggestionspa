import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-suggestion-form',
  templateUrl: './suggestion-form.component.html',
  styleUrls: ['./suggestion-form.component.css']
})
export class SuggestionFormComponent implements OnInit {

  checked = false;

  constructor() { }

  ngOnInit() {
  }

}
