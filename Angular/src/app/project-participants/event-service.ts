import { BehaviorSubject } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class EventService{

    private childClickedEvent = new BehaviorSubject<string>('');
   
     emitChildEvent(msg: string){
        this.childClickedEvent.next(msg)
     }
   
     childEventListner(){
        return this.childClickedEvent.asObservable();
      } 
   
   }