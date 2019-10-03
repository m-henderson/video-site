import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  /**
   * Inputs
   */
  @Input() title: string;
  @Input() description: string;
  @Input() buttonText: string;

  constructor() { }

  ngOnInit() {
  }

}
