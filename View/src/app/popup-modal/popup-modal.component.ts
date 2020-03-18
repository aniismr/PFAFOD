import { Component, OnInit ,Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Dialog } from '../detail-candidat/detail-candidat.component';

@Component({
  selector: 'app-popup-modal',
  templateUrl: './popup-modal.component.html',
  styleUrls: ['./popup-modal.component.scss']
})
export class PopupModalComponent implements OnInit {
  closeResult:string;
  constructor(public dialogRef: MatDialogRef<PopupModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Dialog) { }
    onNoClick(): void {
      this.data.modifier=false;
      this.dialogRef.close();
    }

  ngOnInit(): void {
  }

}
