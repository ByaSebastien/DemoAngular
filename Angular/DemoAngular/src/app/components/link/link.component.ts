import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'li[app-link]',
  templateUrl: './link.component.html',
  styleUrls: ['./link.component.scss']
})
export class LinkComponent implements OnInit {

  @Input()
  path: string;

  @Input()
  title: string;
  
  constructor() { }

  ngOnInit(): void {
  }

}
