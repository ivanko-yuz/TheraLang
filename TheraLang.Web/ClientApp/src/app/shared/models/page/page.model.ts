import { Language } from "../language/languages.enum";

export class Page {
  id?: number;
  header: string;
  content: string;
  menuTitle: string;
  route: string;
  language: Language;
}
