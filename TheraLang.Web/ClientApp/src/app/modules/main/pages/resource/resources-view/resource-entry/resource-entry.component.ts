import {Component, EventEmitter, Input, OnInit, Output} from "@angular/core";
import {Resource} from "../../../../../../shared/models/resource/resource";
import {AuthService} from "../../../../../../core/auth/auth.service";

@Component({
  selector: "app-resource-entry",
  templateUrl: "./resource-entry.component.html",
  styleUrls: ["./resource-entry.component.less"],
})
export class ResourceEntryComponent implements OnInit {

  @Input() resource: Resource;
  @Output() resourceDeleted: EventEmitter<number> = new EventEmitter<number>();

  constructor(
    public authService: AuthService,
  ) { }

  ngOnInit() {
  }

}
