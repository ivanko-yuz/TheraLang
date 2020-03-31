import { Injectable, ErrorHandler, Injector } from "@angular/core";
import { HttpErrorResponse } from "@angular/common/http";
import { Router } from "@angular/router";

@Injectable({
  providedIn: "root",
})
export class ErrorHandlerService implements ErrorHandler {

  constructor(private injector: Injector) { }

  handleError(error: any) {
    const router = this.injector.get(Router);
    console.log("Request URL: ${router.url}");

    if (error instanceof HttpErrorResponse) {
      console.error("Backend returned status code:", error.status);
      console.error("Response body:", error.message);
    } else {
      console.log("An error occurred", error.message);
    }
    router.navigate(["error"]);
  }
}
