import { EntityBase } from "./entity-base";

/**
 * This class is used to model a video object
 */
export class Video implements EntityBase {
  /**
   * Primary key of video
   */
  id: number;

  /**
   * date entity was created
   */
  created: Date;

  /**
   * date the entity was last updated.
   */
  updated: Date;

  /**
   * The title of a video
   */
  title: string;

  /**
   * The detailed descripton of a video
   */
  description: string;

  /**
   * The actual file object of the video being uploaded
   */
  file: File; // TODO: should this be of type File? how will we handle on API?

  /**
   * The tags used for curating and sorting via algorythm
   */
  tags: string[];

  /**
   * The playlist category that the vide is associated with
   */
  playListId: number;

  /**
   * Bit value to determine if the user wants the video to be
   * currated and be behind the metered paywall
   */
  behindPayWall: boolean;
}
