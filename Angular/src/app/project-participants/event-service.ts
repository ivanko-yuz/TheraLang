import { Subject } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class EventService{

    private childClickedEvent = new Subject();
   
     emitChildEvent(){
        this.childClickedEvent.next()
      }
   
     childEventListner(){
        return this.childClickedEvent.asObservable();
      } 
   
   }
